function solve(input){
    let result = input.map(([width, height]) => ({
        width,
        height,
        area: () => width * height,
        compareTo(rect){
            let result = rect.area() - this.area();
        
            return result == 0
            ? rect.width - this.width
            : result
        }
    }))
    .sort((a, b) => a.compareTo(b));

  return result;
}