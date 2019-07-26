# PetRegister
Pet Register REST API
REST API to fetch owners and their pets
To acces API
base URL: https://localhost
Port: 5001
Complete URL: https://localhost:5001\api/petregister

The CRUD functions and endpoints
GET api/petregister              Get all owners and pets.
GET api/petregister/{owner}      Get a pets and owner list.
POST /api/petregister            Create a new petregister list.
PUT /api/petregister/{owner}     Update an existing pet owner.
DELETE /api/petregister/{owner}  Delete a petowner.


The REST API is developed using Visual Studio C#.
1. Import project into Visula studio C#
2. Build Project
3. Publish to a folder where  wish to host the RESTAPI

Database Table mySQL
CREATE TABLE `PetOwner` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Owner` varchar(45) DEFAULT NULL,
  `TypeofAnimal` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
