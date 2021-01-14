function solve(arr) {
    let amountOfRotation = arr.pop();

    for (let i = 0; i < amountOfRotation % arr.length; i++) {
        let lastElement = arr.pop();
        arr.unshift(lastElement);
    }

    console.log(arr.join(' '));
}
