void main(){
  
  final mySquare = new Square(side : -10);
  //mySquare.side = 5;
  
  print('My Area = ${mySquare.area}');
  
}

class Square{
  double _side; // side * side
  
  Square({required double side})
   :assert(side >= 0, 'side must b greater or equal than 0'),
    _side = side;
  
  double get area {
    return _side*_side;
  }
  
  set side(double value){
    print('setting new value $value');
    if (value < 0) throw 'Value most be greater than 5';
    _side = value;
  }
  
  double calculatedArea(){
    return _side* _side;
  }
}