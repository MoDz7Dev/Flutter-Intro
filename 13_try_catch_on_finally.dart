void main() async{
  print('Inicio del Programa');
  
  try{
    final value = await httpGet('https://modz7.com');
  print('Exito: $value');
  } on Exception catch(err){
    print('Tenemos una excepcion: $err');
  }
  catch(err){
    print('Opps¡¡ algo terrible paso: $err');
  } finally {
    print('Fin del try y catch');
  }
  
  
  print('Fin del programa');
}

Future<String> httpGet(String url) async{
  await Future.delayed(const Duration(seconds: 1));
  throw new Exception('No hay parametros en el url');
  //throw 'error en la peticion';
  //return 'tenemos un valor de retorno';
}