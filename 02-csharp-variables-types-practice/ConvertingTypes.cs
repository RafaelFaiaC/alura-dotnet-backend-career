/*Converting Types

Imagine you are developing a cargo management system for a large distribution center. To optimize transport, the company has established that each vehicle must carry exactly 1 ton. Your system needs to convert the total weight of the containers into a whole number of required vehicles, discarding any decimal fraction (since a vehicle cannot be allocated to carry only part of the cargo).

Your program must:
- Receive the total weight in tons (decimal).
- Convert it to an integer, discarding the decimal part.
- Display the minimum number of required vehicles.

Example Input:
decimal containerWeight = 18.75m;

Expected Output:
Required vehicles: 18
*/

decimal containerWeight = 18.75m;
int requiredVehicles = (int)containerWeight;