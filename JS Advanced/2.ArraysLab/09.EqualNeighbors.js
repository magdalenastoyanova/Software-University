function solve(matrix) {
    let equalNeighbors = 0;

    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[row].length; col++) {
            const element = matrix[row][col];

            if (row < matrix.length - 1) {
                if (element === matrix[row + 1][col]) {
                    equalNeighbors++;
                }    
            }

            if (col < matrix[row].length - 1) {
                if (element === matrix[row][col + 1]) {
                    equalNeighbors++;                    
                }
            }
        }
    }

    console.log(equalNeighbors);
}