function solve(input) {
  
    let towns = {};
    
    for (let town of input) {
        let name = town.split(' <-> ')[0];
        let population = Number(town.split(' <-> ')[1]);

        if (towns.hasOwnProperty(name) == false) {
            towns[name] = 0;
        }

        towns[name] += population;
    }
    
    for (let townPopulation of Object.entries(towns)) {
        let town = townPopulation[0];
        let population = townPopulation[1];
        console.log(`${town} : ${population}`);
    }
}
