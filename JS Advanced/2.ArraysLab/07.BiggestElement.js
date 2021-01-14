function solve(matrix) {
    let biggestNum = (Number.MIN_SAFE_INTEGER);

    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[row].length; col++) {
            const num = matrix[row][col];

            if (num > biggestNum) {
                biggestNum = num;
            }
        }
    }

    console.log(biggestNum);
}
