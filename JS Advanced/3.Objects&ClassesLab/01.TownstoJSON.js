function solve(input) {
    let towns = [];
    let splitPattern = /\s*\|\s*/;

    for (let i = 1; i < input.length; i++) {
        let town = {};
        let args = input[i].split(splitPattern).filter(x => x);

        town["Town"] = args[0];
        town["Latitude"] = Number(Number(args[1]).toFixed(2));
        town["Longitude"] = Number(Number(args[2]).toFixed(2));

        towns.push(town);
    }

    let result = JSON.stringify(towns);
    console.log(result);
}