void main() {
  
  final Map<String, dynamic> pokemon = {
    
    'name':'Pikachu',
    'hp':100,
    'isAlive':true,
    'abilities':<String>['Impostor'],
    'sprites':{
      1:'pikachu/front.png',
      2:'pikachu/back.png'
    }
    
  };
  
  print(pokemon);
  print('Name: ${pokemon['name']}');
  print('HP: ${pokemon['hp']}');  
  print('Front: ${pokemon['sprites'][1]}');
  print('Back: ${pokemon['sprites'][2]}');
  
  
}