function systemComponents(input) {
    let systems = new Map();
    for (const line of input) {
        let [system, component, subComponent] = line.split(' | ');

        if (systems.has(system) == false) {
            systems.set(system, new Map());
        }
        if (systems.get(system).has(component) == false) {
            systems.get(system).set(component, []);
        }
        systems.get(system).get(component).push(subComponent);
    }

    let systemsSorted = new Map(
        Array.from(systems)
            .sort((a, b) => {
                return a[0] > b[0]; // a[0], b[0] is the key of the map
            })
            .sort((a, b) => {
                return b[1].size - a[1].size; // a[1], b[1] is the value of the map
            })
    );

    for (const system of systemsSorted) {
        console.log(system[0]);

        let componentsSorted = new Map(
            Array.from(system[1])
                .sort((a, b) => {
                    return b[1].length - a[1].length;
                })
        );

        for (const component of componentsSorted) {
            console.log(`|||${component[0]}`);

            for (const subComponent of component[1]) {
                console.log(`||||||${subComponent}`);
            }
        }
    }
}