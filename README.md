# Animals
ASP.Net project about animals with RAM repository. Program can write information into local file
</br>
</br>
Program operating conditions.</br>
1. There are 4 animals classes in the program: Animal (abstract), Mammal, Reptile and Amphibia.</br>
2. The program is managed by AnimalController and AnimalService.</br>
3. Server works with RAM repository (additional class AnimalRepository with list of animals).</br>
4. Any object, from available 3 classes (Mammal, Reptile or Amphibia), can be created.</br>
5. Program operates from Swagger on localhost.</br>
6. Realized REST API requests: POST, GET:</br>
- POST with save in repository;</br>
- POST with save in repository and write into local file;</br>
- GET of all animals;</br>
- GET animal by ID;</br>
- GET animal by name;</br>
- GET animal by sound.</br>
