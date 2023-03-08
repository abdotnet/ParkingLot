Objects  defination :
·   	Parking Lot: This is the main object that represents the parking lot itself.
·   	Parking Space: This is an object that represents a single parking space within the parking lot.
·   	Vehicle: This is an object that represents a vehicle that can park in the parking lot.
Now, let's define the properties and methods for each of these objects:
1. 	Parking Lot:
·   	Properties:
·   	Capacity: The total number of parking spaces in the lot.
·   	Available Spaces: The number of parking spaces that are currently available.
·   	Parking Spaces: An array or list of all the Parking Space objects in the parking lot.
·   	Methods:
·   	AddVehicle(vehicle): Adds a Vehicle object to the parking lot, if there is an available parking space.
·   	RemoveVehicle(vehicle): Removes a Vehicle object from the parking lot, if it is parked there.
·   	GetAvailableSpaces(): Returns the number of available parking spaces in the parking lot.
2. 	Parking Space:
·   	Properties:
·   	Space Number: A unique identifier for each parking space.
·   	Vehicle: The Vehicle object that is currently parked in the space (or null if the space is empty).
·   	Methods:
·   	IsAvailable(): Returns true if the space is currently empty and available for parking.
3. 	Vehicle:
·   	Properties:
·   	License Plate Number: A unique identifier for the vehicle.
·   	Type: The type of vehicle (car, truck, motorcycle, etc.).
·   	Methods:
·   	GetType(): Returns the type of the vehicle.
With these objects and methods defined, you could create a parking lot instance, initialize it with a certain capacity and parking spaces, and then use the AddVehicle and RemoveVehicle methods to manage the parking of vehicles in the lot. The IsAvailable and GetAvailableSpaces methods could be used to display information about the availability of parking spaces in the lot.
 
