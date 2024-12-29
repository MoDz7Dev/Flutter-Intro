void main(){
  final windPlant = WindPlant( initialEnergy: 100  );
  final nuclearPlant = NuclearPlant( energyLeft: 1000);
  
  print('wind: ${chargePhone(windPlant)}');
  print('nuclear: ${chargePhone(nuclearPlant)}');
}

double chargePhone(EnergyPlant plant){
  if (plant.energyLeft < 10){
    throw Exception('Not enough energy...');
  }
  return plant.energyLeft - 10;
}

enum PlantType {nuclear, wind, water}

abstract class EnergyPlant {
  double energyLeft;
  final PlantType type;
  EnergyPlant({
    required this.energyLeft,
    required this.type});
  void consumeEnergy(double amount);
}


//EXTENDS O IMPLEMENTS

//Extends: sirve para extender todos los metodos de la clase padre
class WindPlant extends EnergyPlant {
  WindPlant({required double initialEnergy})
    : super(energyLeft: initialEnergy, type : PlantType.wind);
  
  @override
  void consumeEnergy(double amount){
    energyLeft -= amount;
  }
}

//Implements: sirve para implementar uno o mas metodos especificos de la clase padre
class NuclearPlant implements EnergyPlant {
  @override
  double energyLeft;
  final PlantType type = PlantType.nuclear;
  
  @override
  NuclearPlant({required this.energyLeft});
  
  @override
  void consumeEnergy(double amount){
    energyLeft -= (amount * 0.5);
  } 
}
