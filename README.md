CarZo
Summary
CarZo is a C# program that models different types of vehicles, including cars, motorcycles, and trucks, using object-oriented programming principles. The program defines an interface called IDriveable, which specifies a method Drive() that all vehicles must implement.

Key Components:
IDriveable: An interface containing the Drive() method. This method is used to operate the vehicle.

Vehicle: An abstract class representing common properties of all vehicles, such as Brand and Model. It includes a constructor and a ToString() method to provide a string representation of the vehicle.

Car: A class that inherits from Vehicle and implements IDriveable. It has a property called NumberOfPassengers, which represents the number of passengers the car can transport, along with an implementation of the Drive() method.

Motorcycle: A class that inherits from Vehicle and implements IDriveable. It includes a property called HasSidecar, which indicates whether the motorcycle has a sidecar, and provides an implementation of the Drive() method.

Truck: A class that also inherits from Vehicle and implements IDriveable. It contains a property called NumberOfAxles, which represents the number of axles on the truck, along with an implementation of the Drive() method.

The program provides a structured and extensible codebase for managing various types of vehicles and their behaviors, making it easy to add new vehicle types or features in the future.

Usage
The program can be used to create instances of different vehicles and operate them, demonstrating how object-oriented programming can be utilized to model real-world objects and their behaviors in a software application.

