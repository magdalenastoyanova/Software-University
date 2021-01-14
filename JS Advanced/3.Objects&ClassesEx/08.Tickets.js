function tickets(arr, criteria) {
    class Tickets {
        constructor(descriptor) {
            let [destination, price, status] = descriptor.split("|");
            this.destination = destination;
            this.price = Number(price);
            this.status = status;
        }
    }
 
    return arr
        .map(ticket => new Tickets(ticket))
        .sort(sortByCriteria);
 
 
    function sortByCriteria(a, b) {
        try {
            return a[criteria].localeCompare(b[criteria]);
        } catch(e) {
            return a[criteria] - b[criteria];
        }
    }
}
 