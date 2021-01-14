function solve(input){
    let products={};
    input.forEach(line=> {
        let [name,price]=line.split(" : ");
        products[name]=price;
 
    });
    let letter="";
    Object.entries(products)
        .sort((a,b)=>a[0].localeCompare(b[0]))
        .forEach(([name,price])=>{
            if(name[0]!==letter){
                letter=name[0];
                console.log(name[0]);
            }
            console.log(`  ${name}: ${price}`)
        })
    }