function solve(input) {
    let towns = {};

    for (let i = 0; i < input.length; i += 2) {
        let name = input[i];
        let income = Number(input[i + 1]);

        if (towns.hasOwnProperty(name) === false) {
            towns[name] = 0;
        }

        towns[name] += income;
    }

    towns = JSON.stringify(towns);
    console.log(towns);
}