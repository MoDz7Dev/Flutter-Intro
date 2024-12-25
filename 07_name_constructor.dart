void main() {
  
  final Map<String, dynamic> rawJson = {
    'name': 'Tony Stark',
      'power': 'Money',
        'isAlive': true
  };
  
  final ironMan = new Hero.fromJson(rawJson);
  
  
  //final ironMan = new Hero(
    //isAlive : false,
    //name : 'Tony Stark',
    //power : 'Dinero'
  //);
  
  print(ironMan);
}

class Hero{
  
  String name;
  String power;
  bool isAlive;
  
  Hero({
    required this.name,
    required this.power,
    required this.isAlive
  });
  
  Hero.fromJson(Map<String, dynamic> json) 
    : name = json['name']??'No name found',
      power = json['power']??'No power found',
      isAlive = json['isAlive']??'Unknow';
  
  @override
  String toString(){
    return '$name, $power,${isAlive ? ' YES¡':' Nope'}';
  }
}