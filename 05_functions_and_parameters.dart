void main() {
  print(greetEveryone());
  print(greetEveryoneArrowFunction());
  print('Suma: ${addTwoNumbers(10,20)}');
  print('Suma2: ${addTwoNumbersArrow(10,20)}');
  print( greetPerson(name: 'Javier', message: 'Whats up, ') );
}

//Funcion corriente con procedimiento
String greetEveryone(){
  return 'Hello Everyone';
}

//Funcion de flecha unicamente permite el retorno de un valor
String greetEveryoneArrowFunction() => 'HelloEveryone¡';

int addTwoNumbers(int a,int b){
  return a+b;
}

int addTwoNumbersArrow(int a,int b)=> a + b;

//Para parametros opcionales dentro de una funcion se usan "[]"
int addTwoNumbersOptional(int a, [int? b]){
  b = b ?? 0;
  return a + b;
}

//Parametros opcionales al poner los parametros dentro de llaves estos se vuelven opcionales
//no son necesarios declararlos al llamar a la funcion exceptuando por aquellos que llevan
//required detras de estos ya que estos los vuelve parametros obligatorios
String greetPerson({ required String name, String message = 'Hola, '}){
  return '$message Javier';
}