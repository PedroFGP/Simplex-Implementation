package br.com.webservice;

import java.io.IOException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

class CellDouble {
   //atributos
   public double upperCell;
   public double lowerCell;

   //construtor vazio
    public CellDouble ( ){ 
       this.upperCell = 0;
       this.lowerCell = 0;
   }
   //construtor
    public CellDouble (double up, double low){ 
       this.upperCell = up;
       this.lowerCell = low;

   }
}//end célula

class Simplex {
   
   //Declaração de variáveis
   public String variableValue = "";
   public String variable = "";
   public int pointRow = 0;
   public int pointCol = 0;
   public boolean OnceMore = true;
   public boolean fase3 = false;
   public String type = "";
   public String ReturnMessage = "";
   
   //Print Matriz
   public void printMatrix (CellDouble matrix[][], int row, int col){
       //Print
       System.out.println("Matrix");
       for (int i = 0; i < matrix.length; i++) {
           for (int j = 0; j < matrix[i].length; j++) {
               System.out.print("(" + matrix[i][j].upperCell + "/" + matrix[i][j].lowerCell + ")");
           }
           System.out.println();
       }
   }
   public void printMatrix (double matrix[][], int row, int col){
       //Print
       System.out.println("Matrix Inicial");
       for (int i = 0; i < matrix.length; i++) {
           for (int j = 0; j < matrix[i].length; j++) {
               System.out.print("(" + matrix[i][j] + ")");
           }
           System.out.println();
       }
   }
   public void printMatrix (String matrix[][], int row, int col){
       //Print
       System.out.println("Matrix Completa");
       for (int i = 0; i < matrix.length; i++) {
           for (int j = 0; j < matrix[i].length; j++) {
               System.out.print("(" + matrix[i][j] + ")");
           }
           System.out.println();
       }
   }
   /*
   * Tratar a função objetiva recebida
   * Obter a quantidade de variáveis e a quantidade de restrições
   */
   public void TreatFO (String FOType, String z,int restrictions, String matrixIn[][]){
       type = FOType;
       String zSplit [] = z.split(" ");
       int count = 0;
       
       List<String> listOperators = new ArrayList<String>();
       List<String> listValues = new ArrayList<String>();
       List<String> fo = new ArrayList<String>();
       List<String> listVariables = new ArrayList<String>();
       
       //Leitura da função objetiva 
       for (int k = 0; k < zSplit.length; k++){
          count = 0;
          for (int i = 0; i < zSplit[k].length(); i++){
               char c = zSplit[k].charAt(i);
               if ((c >= '0'&& c <= '9') || c == '.') {
                   variableValue += c;
                   count++;
               }else{
                   break;
               }
           }
           variable = zSplit[k].substring(count, zSplit[k].length());
           if (variable.contains("+") 
                   || variable.contains("-") 
                   || variable.contains(">") 
                   || variable.contains("<") 
                   || variable.contains(">=") 
                   || variable.contains("<=") 
                   || variable.contains("*") 
                   || variable.contains("/") 
                   || variable.contains("=")) {
               listOperators.add(variable);
           }else {
               listVariables.add(variable);
           }
           listValues.add(variableValue);
           variableValue = "";
       }
       
       //Definição do número de variáveis do problema
       int variables = listVariables.size();

       //Tratamento da FO caso ela seja de maximização
       fo.add("0");
       if(FOType.equals("MAX")) {
           for (String value: listValues) {
               if(value != null && value != "") {
                   double negVal = Double.parseDouble(value)*(-1); 
                   fo.add(Double.toString(negVal));
               }
           }
       }else {
           for (String value: listValues) {
               if(value != null && value != "") {
                   fo.add(value);
               }
           }
       }
       TreatRestrictions(variables, restrictions, matrixIn,fo);
   }
   /*
   * Cria matriz transformando as restrições recebidas nas funções de membros livres do simplex
   */
   public void TreatRestrictions(int variables, int restrictions, String matrixIn[][],List<String> fo){
       //tratar restrições para formato Simplex 1
       int tam = variables + (variables - 1)+2;
       double matrixR [][] = new double [restrictions][variables + 1];
       
       //Membro Livre
       for (int l = 0; l < restrictions; l++){
           
           boolean lessOrEqual = false;
           
           if (matrixIn[l][tam-2].equals("<=")){
               matrixR[l][0] = Double.parseDouble(matrixIn[l][tam-1]); //+
               lessOrEqual = true;
           }else if (matrixIn[l][tam-2].equals(">=")){
               matrixR[l][0] = Double.parseDouble("-" + matrixIn[l][tam-1]); //-
           }
           
           int count = 0;
           
           for (int j = 1; j < tam-2; j++){
               String celula = matrixIn[l][j-1];

               if (celula.equals("+") || celula.equals("-")){
                   if(j <= tam-2){
                       celula = matrixIn[l][j];
                       j++;
                   }else{
                       break;
                   }
               }

               count++;
               
               double temp = Double.parseDouble(celula);
               temp = temp * (-1);
               if (temp >= 0){
                   temp = temp * -1;
                   matrixR[l][count] = temp;
               }else if (temp < 0){
                   matrixR[l][count] = (lessOrEqual) ? (-1) * temp : temp;
               }
           }
       }
       //Print
       //printMatrix(matrixR,restrictions,variables);
       matrix01(matrixR,restrictions,variables,fo);
       
   }//end TreatRestrictions
   /*
   * Montagem da primeira matriz que passarápelo simplex
   */
   public void matrix01(double matrixR [][],int r, int v, List<String> fo) {
       int row = r+1;
       int col = v+1;
       //Montar Matriz Simplex 1
       CellDouble [][] matrix1 = new CellDouble [row][col]; 
       
       for (int l = 0; l < row; l++) {
           for (int c = 0; c < col; c++){
               matrix1[l][c] = new CellDouble();
           }
       }
       
       //Preencher FO
       for (int val = 0; val < col; val++) {
           double temp = Double.parseDouble(fo.get(val));
           if(temp == 0){
               matrix1[0][val].upperCell = (0);
           }else {
               temp = (-1)*temp;
              matrix1[0][val].upperCell = (temp); 
           }
       }
       
       //Preencher restrições
       for (int l = 1;l < row; l++) {
           for (int c = 0; c < v+1; c++){
               double temp = matrixR[l-1][c];
               matrix1[l][c].upperCell = temp;
           } 
       }

       //Print
       //printMatrix(matrix1,row,col);
       simplex1(matrix1,row,col);
   }
   /*
   * Método de repetição Simplex
   */
   public void simplex1 (CellDouble matrix1 [][],int row, int col) {

//       //Montar Matriz Simplex 1
       CellDouble [][] matrixSimplex = new CellDouble [row][col]; 
       
       for (int l = 0; l < row; l++) {
           for (int c = 0; c < col; c++){
               matrixSimplex[l][c] = new CellDouble();
           }
       }
       //Montar Matriz Simplex 1
       CellDouble [][] matrixSimplex2 = new CellDouble [row][col]; 
       
       for (int l = 0; l < row; l++) {
           for (int c = 0; c < col; c++){
               matrixSimplex2[l][c] = new CellDouble();
           }
       }
       
       //Montar Matriz Simplex 1
       int r = row+1;
       int c = col+1;
       String [][] matrixSimplexCompleta = new String [r][c]; 

       //VNB
       matrixSimplexCompleta[0][0] = "VB/VNB";

       //ML
       matrixSimplexCompleta[0][1] = "ML";

       //F(x)
       matrixSimplexCompleta[1][0] = "Z";
       //X VNB
       for (int i = 2; i < r; i++) {
           int val = (col-1) + (i-1);
           matrixSimplexCompleta[i][0]= "x" + val ;
       }
       //X VB
       for (int j = 2; j < c; j++) {
           int val = j-1;
           matrixSimplexCompleta[0][j] = "x"+ val;
       }
       //printMatrix(matrixSimplexCompleta,r,c);
       //Repetição
       while(OnceMore == true) {
           int pointNegRow = simplexFaseOne(matrix1,row,col);
           //Se linha com ML negativo
           if (pointNegRow != -1) {
               boolean neg = simplexFase2(matrix1,row,col,pointNegRow);
               //se coluna com elemento negativo para ML negativo
               if (neg == true) {
                   //matrixSimplex = simplexFase3(matrix1,row,col);
                   matrix1 = simplexFase3(matrix1, row, col,matrixSimplexCompleta);
               }
               //simplex1(matrixSimplex,row,col);
           }else {
               matrixSimplex = matrix1;
               OnceMore = false;
           }
       }
       //Segunda fase do Simplex
       if (OnceMore == false) {
           //se f(x) positivo ignorando ML
           boolean posFX = simplex2Fx(matrixSimplex,row,col);
           //Método 2 fase 1
           if (posFX == true){
               boolean pos = simplex2Pos(matrixSimplex,row,col);
               //Se na coluna permissiva temos um elemento positivo excluindo a linha fx
               if (pos == true){
                   //Método 2 fase 3
                   fase3 = true;  
               }else {
                   //Se tem FX positivo e se na coluna positiva desse elemento não existir elemento positivo
                   //System.out.println("Solução Ilimitada");
                   ReturnMessage += "Solucao ilimitada\n\n";
               }
           }else {
               //Se não existir elemento positivo em fx
               //System.out.println("Solução Ótima");
               ReturnMessage += "Solucao otima\n\n";
           }       
       }
       //Existe um elemento positivo em fx e um elemento positivo nessa coluna de fx
       if(fase3 == true) {
           matrixSimplex2 = simplex2Fase3(matrixSimplex,row,col,matrixSimplexCompleta);
           solution(matrixSimplex2,row,col,matrixSimplexCompleta);
           fase3 = false;
           //printMatrix(matrixSimplexCompleta,r,c);
       } 
   }
   /*
   * simplexFaseOne procura por um membro livre negativo
   */
   public int simplexFaseOne (CellDouble matrix1[][], int row, int col) {  
       int pointNegRow = -1;
       double valor;
       //Para cada linha da coluna ML (0) menos a linha do FO (0)
       for (int l = 1; l < row; l++){
           valor = matrix1[l][0].upperCell;
           if( valor < 0) {
            //linha negativa
           pointNegRow = l; 
           break;
           }
       }
       return pointNegRow;
   } 
  /*
   * Conferir a existência de um elemento negativo na linha que tem ML negativo
   */ 
   public boolean simplexFase2(CellDouble matrix1[][], int row, int col, int pointNegRow) {
       boolean neg = false;
       //Fase 2 :para cada coluna da linha negativa
       for (int j = 1; j < col; j++){
           if (matrix1[pointNegRow][j].upperCell < 0) {
               pointCol = j;
               neg = true;
               break;
           }
       }
       return neg;
   }
   /*
   * Verifica se todos os elementos são positivos
   */
   public boolean AllPositive (CellDouble matrixSimplex[][], int row, int col) {
       boolean positive = false;
       for(int i = 0; i < row; i++) {
           for (int j = 1; j < col; j++){
               if (matrixSimplex[i][j].upperCell >= 0){
                   positive = true;
               }else {
                   positive = false;
                   i = row;
                   break;
               }
           }
       }
       return positive;
   }
   /*
   * Passos do Simplex
   */
   public CellDouble[][] simplexFase3(CellDouble matrix1[][], int row, int col,String matrixSimplexCompleta[][]) {
       double vet[] = new double[row-1];
       for (int i = 1; i < row; i++){
           //Para qualquer linha da coluna permissiva - FO
           if ((matrix1[i][pointCol].upperCell > 0 && matrix1[i][0].upperCell < 0) 
                   || (matrix1[i][pointCol].upperCell < 0 && matrix1[i][0].upperCell > 0)) {
               vet[i-1] = 99999999;
           }else {
               vet[i-1] = (matrix1[i][0].upperCell/matrix1[i][pointCol].upperCell);
           }
       }
       //Encontrar menor denominador
       double small = vet[0];
       pointRow = 0+1;
       for (int i = 0; i < vet.length; i++) {    
           if (vet[i] < small){
               pointRow = i + 1; //+1 porque o vetor não recebe FO, logo ele ignora uma linha da matriz 
               small = vet[i];
           }
       }
       return exchangeAlgorithm(matrix1,row,col,matrixSimplexCompleta);
   }
   /*
    * Algoritmo de troca preenchendo linha e coluna permissiva
    */
   public CellDouble[][] exchangeAlgorithm(CellDouble matrix1[][], int row, int col,String matrixSimplexCompleta[][]){
       matrix1[pointRow][pointCol].lowerCell = 1/matrix1[pointRow][pointCol].upperCell;
       //linha permisiva
       for (int j = 0; j < col; j++) {
           if (matrix1[pointRow][j].lowerCell == 0) {
               if (matrix1[pointRow][j].upperCell == 0) {
                   matrix1[pointRow][j].lowerCell = 0;
               }else if (matrix1[pointRow][j] == matrix1[pointRow][pointCol]){
                   matrix1[pointRow][j].lowerCell = 1/matrix1[pointRow][pointCol].upperCell;
               }else {
                   matrix1[pointRow][j].lowerCell = matrix1[pointRow][j].upperCell * matrix1[pointRow][pointCol].lowerCell;
               }
           }
       }
       //coluna permissiva
       double neg = (-1)*(1/matrix1[pointRow][pointCol].upperCell);
       for (int i = 0; i < row; i++){
           if (matrix1[i][pointCol].lowerCell == 0){
               if (matrix1[i][pointCol].upperCell == 0) {
                   matrix1[i][pointCol].lowerCell = 0;
               }else if (matrix1[i][pointCol] == matrix1[pointRow][pointCol]){
                   matrix1[i][pointCol].lowerCell = 1/matrix1[pointRow][pointCol].upperCell;
               }else {
                   matrix1[i][pointCol].lowerCell = matrix1[i][pointCol].upperCell * neg;
               }
           }
       }
       //Print
       //printMatrix(matrix1,row,col);
       return fillTable(matrix1, row, col,matrixSimplexCompleta);
   }
   /*
    * Preenchimento dos campos não permissivos
    */
   public CellDouble [][] fillTable (CellDouble matrix1[][], int row, int col,String matrixSimplexCompleta[][]) {
       for (int i = 0; i < row; i++){
           for (int j = 0; j < col; j++) {
               //se linha e coluna não forem as permissíveis
               if (j != pointCol && i != pointRow) {
                   //SCI = SCS(da coluna atual na linha permissivel) * SCI(coluna permissível na linha atual)
                   matrix1[i][j].lowerCell = (matrix1[pointRow][j].upperCell * matrix1[i][pointCol].lowerCell);
               }
           }
       }
       //Print
       //printMatrix(matrix1,row,col);
       
       //trocar linha permissivel com coluna permissível]
       String temp = matrixSimplexCompleta[pointRow+1][0];
       //original upper = pointCol & lower = pointRow
       matrixSimplexCompleta[pointRow+1][0] = matrixSimplexCompleta[0][pointCol+1];
       matrixSimplexCompleta[0][pointCol+1] = temp;

       return newTable(matrix1,row,col,matrixSimplexCompleta);
   }
   /*
    * Nova tabela trocando as SCS pelas SCI na linha e coluna permissiva
    * SCI = 0
    * SCS das não permisivas = SCS + SCI
    */
   public CellDouble[][]  newTable(CellDouble matrix1[][], int row, int col, String matrixSimplexCompleta [][]){
       CellDouble matrix2 [][] = new CellDouble[row][col];
       for (int i = 0; i < row; i++){
           for (int j = 0; j < col; j++) {
               matrix2[i][j] = new CellDouble();
           }
       }
       
       for (int i = 0; i < row; i ++) {
           for (int j = 0; j < col; j++) {
               if (i == pointRow || j == pointCol){
                   matrix2[i][j].upperCell = matrix1[i][j].lowerCell;   
               }else {
                   matrix2[i][j].upperCell = (matrix1[i][j].upperCell + matrix1[i][j].lowerCell);
               } 
           }
       }
       //Print
       //printMatrix(matrix2,row,col);
       return matrix2;
   }
   //Método 2 Simplex
   /*
    * Procura elemento positivo no F(X) ignorando o ML
    */
   public boolean simplex2Fx(CellDouble matrix2[][],int row, int col){
       boolean pos = false;
       for (int j = 1; j < col; j++) {
           //Se existir elemnto positivo em f(x)
           if (matrix2[0][j].upperCell > 0) {
               //coluna permissiva
               pointCol = j;
               j = col;
               pos = true;
               break;
           }else {
               pos = false;
           }
       }
       return pos;
   }
   /*
    * Procura elemento positivo em alguma linha da coluna positiva encontrada pelo simplex2FX
    */
   public boolean simplex2Pos (CellDouble matrix2 [][], int row, int col) {
       boolean pos = false;
       //para cada linha
       for (int i = 1; i < row; i ++) {
           //se existir elemento positivo na linha atual na coluna permissiva
           if (matrix2[i][pointCol].upperCell > 0){
               pos = true;
               i = row; 
               break;
           }else {
               pos = false;
           }
       }
       return pos;
   }
   /*
    * Encontrar o menor denominador 
    */
   public CellDouble [][] simplex2Fase3 (CellDouble matrix2[][], int row, int col, String matrixSimplexCompleta [][]) {
       double vet[] = new double [row-1];
       for (int i = 1; i < row; i++) {
           if ((matrix2[i][pointCol].upperCell > 0 && matrix2[i][0].upperCell < 0) 
                   || (matrix2[i][pointCol].upperCell < 0 && matrix2[i][0].upperCell > 0)) {
               vet[i-1] = 99999999;
           }else {
               vet[i-1] = (matrix2[i][0].upperCell/matrix2[i][pointCol].upperCell);
           }
       }
      //Encontrar menor denominador
       double small = vet[0];
       pointRow = 0+1;
       for (int i = 0; i < vet.length; i++) {    
           if (vet[i] < small){
               pointRow = i + 1; //+1 porque o vetor não recebe FO, logo ele ignora uma linha da matriz 
               small = vet[i];
           }
       }
       return exchangeAlgorithm2(matrix2, row, col,matrixSimplexCompleta);
   }
   /*
    * Roda algoritmo de troca uma vez
    */
   public CellDouble[][] exchangeAlgorithm2(CellDouble matrix2[][], int row, int col, String matrixSimplexCompleta [][]){
       matrix2[pointRow][pointCol].lowerCell = 1/matrix2[pointRow][pointCol].upperCell;
       //linha permisiva
       for (int j = 0; j < col; j++) {
           if (matrix2[pointRow][j].lowerCell == 0) {
               if (matrix2[pointRow][j].upperCell == 0) {
                   matrix2[pointRow][j].lowerCell = 0;
               }else if (matrix2[pointRow][j] == matrix2[pointRow][pointCol]){
                   //matrix2[pointRow][j].lowerCell = 1/matrix2[pointRow][pointCol].upperCell;
               }else {
                   matrix2[pointRow][j].lowerCell = matrix2[pointRow][j].upperCell * matrix2[pointRow][pointCol].lowerCell;
               }
           }
       }
       //coluna permissiva
       double neg = (-1)*(1/matrix2[pointRow][pointCol].upperCell);
       for (int i = 0; i < row; i++){
           if (matrix2[i][pointCol].lowerCell == 0){
               if (matrix2[i][pointCol].upperCell == 0) {
                   matrix2[i][pointCol].lowerCell = 0;
               }else if (matrix2[i][pointCol] == matrix2[pointRow][pointCol]){
                   matrix2[i][pointCol].lowerCell = 1/matrix2[pointRow][pointCol].upperCell;
               }else {
                   matrix2[i][pointCol].lowerCell = matrix2[i][pointCol].upperCell * neg;
               }
           }
       }
       return fillTable2 (matrix2,row,col, matrixSimplexCompleta);
   }
   /*
    * Preencher tabela do algoritmo de troca
    */
   public CellDouble [][] fillTable2 (CellDouble matrix2[][],int row,int col, String matrixSimplexCompleta [][]){
       for (int i = 0; i < row; i++){
           for (int j = 0; j < col; j++) {
               //se linha e coluna não forem as permissíveis
               if (j != pointCol && i != pointRow) {
                   //SCI = SCS(da coluna atual na linha permissivel) * SCI(coluna permissível na linha atual)
                   matrix2[i][j].lowerCell = (matrix2[pointRow][j].upperCell * matrix2[i][pointCol].lowerCell);
               }
           }
       }
       //trocar linha permissivel com coluna permissível]
       String temp = matrixSimplexCompleta[pointRow+1][0];
       //original upper = pointCol & lower = pointRow
       matrixSimplexCompleta[pointRow+1][0] = matrixSimplexCompleta[0][pointCol+1];
       matrixSimplexCompleta[0][pointCol+1] = temp;

       return newTable2(matrix2,row,col,matrixSimplexCompleta);
   }
   /*
    * Nova tabela pós troca
    */
   public CellDouble [][] newTable2(CellDouble matrix1[][], int row, int col, String matrixSimplexCompleta [][]){
       //printMatrix(matrix1,row,col);
       CellDouble matrix2 [][] = new CellDouble[row][col];
       for (int i = 0; i < row; i++){
           for (int j = 0; j < col; j++) {
               matrix2[i][j] = new CellDouble();
           }
       } 
       for (int i = 0; i < row; i ++) {
           for (int j = 0; j < col; j++) {
               if (i == pointRow || j == pointCol){
                   matrix2[i][j].upperCell = matrix1[i][j].lowerCell;   
               }else {
                   matrix2[i][j].upperCell = (matrix1[i][j].upperCell + matrix1[i][j].lowerCell);
               } 
           }
       }
       //Print
       //printMatrix(matrix2,row,col);
       return matrix2;
   }
   /*
    * Solução
    */
   
   public void solution (CellDouble matrix[][], int row, int col, String matrixSimplexCompleta [][]){
       if (type.equals("MAX")) {
           
           for(int i = 0; i < row; i++) {
               for (int j = 0; j< col; j++){
                   if (i == 1 && j ==1){
                       matrixSimplexCompleta[1][1] = String.valueOf((-1)*matrix[0][0].upperCell); 
                   }else {
                       matrixSimplexCompleta[i+1][j+1] = String.valueOf(matrix[i][j].upperCell);
                   }
               }
           }
       }else {
           //If MIN
           for(int i = 0; i < row; i++) {
               for (int j = 0; j< col; j++){
                   matrixSimplexCompleta[i+1][j+1] = String.valueOf(matrix[i][j].upperCell);
               }
           } 
       }
       //Busca ML negativo
       int MLneg = MLNeg(matrix,row,col);
       if(MLneg != -1){//se negativo
           //System.out.println("Solução permissível não existe. Impossível");    
    	   
    	   ReturnMessage += "Solucao permissivel nao existe. Impossivel\n\n";
       }else {
           //ML positivo
           boolean pos = simplex2Fx(matrix,row,col);//FX positivo?
           if ((matrix[1][2].upperCell == 0 && matrix[1][3].upperCell < 0) || (matrix[1][2].upperCell < 0 && matrix[1][3].upperCell == 0)){
               //System.out.println("Multiplas soluções");
               ReturnMessage += "Multiplas solucoes\n\n";
           }else if (pos == true){
               //coluna permissivel no fx positivo
               for (int i = 1; i < row; i ++){
                   if(matrix[i][pointCol].upperCell > 0){
                       //Não fala o que fazer
                       //System.out.println("Não exite solução padrão para esse problema");
                       
                       ReturnMessage += "Nao exite solucao padrao para esse problema\n\n";
                       i = row;
                       break;
                   }else{
                       //System.out.println("Solução Ótima não existe. Ilimitada");
                       
                       ReturnMessage += "Solucao otima nao existe. Ilimitada\n\n";
                   }
               }
           }else{
               //System.out.println("Solução Ótima");
               
               ReturnMessage += "Solucao otima\n\n";
           }   
       }
       
       //Print da solução, valores da função objetiva Z, e das variaveis básicas
     
       for (int i = 1; i < row+1; i++) {
       		//System.out.print(matrixSimplexCompleta[i][0] + " = " + matrixSimplexCompleta[i][1] + '\n' );
       		
       		ReturnMessage += matrixSimplexCompleta[i][0] + " = " + matrixSimplexCompleta[i][1] + '\n';
       }
       for (int j = 2; j < col+1; j++) {
       		//System.out.print(matrixSimplexCompleta[0][j] + " = " + "0" + '\n' );
       		
       		ReturnMessage += matrixSimplexCompleta[0][j] + " = " + "0" + '\n' ;
       }
   }
   
   /*
   * ML negativo
   */
   public int MLNeg (CellDouble matrix[][], int row, int col){
       int pointNegRow = -1;
       double valor;
       //Para cada linha da coluna ML (0) menos a linha do FO (0)
       for (int l = 1; l < row; l++){
           valor = matrix[l][0].upperCell;
           if( valor < 0) {
            //linha negativa
           pointNegRow = l; 
           break;
           }
       }
       return pointNegRow;
   }
   
   /*
   * Neg element
   */
   public boolean NegElement (CellDouble matrix[][], int row, int col, int pointNegRow){
       boolean neg = false;
       double valor;
       for (int c = 0; c < col; c++){
           valor = matrix[pointNegRow][c].upperCell;
           if( valor < 0) {
            //linha negativa
           neg = true; 
           break;
           }
       }
       return neg;
   }

}//end Simplex

/**
 * Servlet implementation class WebService
 */
@WebServlet("/")
public class WebService extends HttpServlet 
{
	private static final long serialVersionUID = 1L;

	/**
     * @see HttpServlet#HttpServlet()
     */
    public WebService() 
    {
        super();
    }
    
	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */    
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException 
	{
		//Recuperar os valores dos parâmetros da requisição POST
		String type = request.getParameter("Type");
		String problemDescription = request.getParameter("Description");
		int varCount = Integer.parseInt(request.getParameter("VariableCount"));
		varCount += (varCount-1) + 2;
		int restrictionCount = Integer.parseInt(request.getParameter("RestrictionCount"));
		String z = request.getParameter("FO(Z)");
		
		Map<String, String[]> parameterMap = new HashMap<String, String[]>(request.getParameterMap());
		
		//Remover os parâmetros já recuperados
		parameterMap.remove("Type");
		parameterMap.remove("VariableCount");
		parameterMap.remove("RestrictionCount");
		parameterMap.remove("FO(Z)");
		parameterMap.remove("Description");
		
		String [][] matrixIn = new String [restrictionCount][varCount];
		
		//Para cada restrição formatá la para passar de maneira correta para o simplex
		for (int row = 0; row < restrictionCount; row++) 
		{
			String value = request.getParameter("R"+(row+1));
			
			String[] splitedValue = value.split(" ");
			
			for(int column = 0; column < varCount; column++)
			{
				matrixIn[row][column] = splitedValue[column];
			}
		}
		
		String returnMessage = "";
		
		//Formatar a mensagem de retorno com o problema original
		for(String part : problemDescription.split(";"))
		{
			returnMessage += part + "\n";
		}
		
		returnMessage += "\n";
		
		//Instanciar o resolvedor de simplex
		Simplex SimplexInstance = new Simplex();
		
		//Chamar o resolvedor
		SimplexInstance.TreatFO(type, z, restrictionCount, matrixIn);
		
		//Formatar a mensagem de retorno com a mensagem de retorno do Simplex
		returnMessage += SimplexInstance.ReturnMessage;
		
		//Mandar a resposta da requisição POST
		response.getWriter().write(returnMessage);
	}
}
