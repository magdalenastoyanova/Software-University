class VeterinaryClinic {
    constructor(clinicName, capacity) {
      this.clinicName = clinicName;
      this.capacity = capacity;
      this.clients = [];
      this.currentWorkload = 0;
      this.totalProfit = 0;
    }
   
    newCustomer(ownerName, petName, kind, procedures) {
      if (this.currentWorkload >= this.capacity) {
        throw new Error('Sorry, we are not able to accept more patients!');
      }
   
      let customer = this.clients.find((c) => c.ownerName === ownerName);
      if (!customer) {
        customer = {
          ownerName,
          pets: [],
        };
        this.clients.push(customer);
      }
   
      let pet = customer.pets.find((p) => p.petName === petName);
      if (!pet) {
        pet = {
          petName,
          kind,
          procedures,
        };
   
        if (procedures.length > 0) {
          this.currentWorkload++;
        }
   
        customer.pets.push(pet);
        return `Welcome ${petName}!`;
      }
   
      if (pet.procedures.length > 0) {
        throw new Error(`This pet is already registered under ${ownerName} name! ${petName} is on our lists, waiting for ${pet.procedures.join(', ')}.`);
      }
   
      pet.procedures.concat(procedures);
   
      return `Welcome ${petName}!`;
    }
   
    onLeaving(ownerName, petName) {
      const customer = this.clients.find((c) => c.ownerName === ownerName);
      if (!customer) {
        throw new Error('Sorry, there is no such client!');
      }
   
      const pet = customer.pets.find((p) => p.petName === petName);
      if (!pet || pet.procedures.length === 0) {
        throw new Error(`Sorry, there are no procedures for ${petName}!`);
      }
   
   
      this.totalProfit += this.calculateBill(pet);
      this.currentWorkload--;
   
      pet.procedures = [];
   
      return `Goodbye ${petName}. Stay safe!`;
    }
   
    toString() {
      const result = [];
      const clinickBusiness = Math.floor((this.currentWorkload / this.capacity) * 100);
   
      result.push(`${this.clinicName} is ${clinickBusiness}% busy today!`);
      result.push(`Total profit: ${this.totalProfit.toFixed(2)}$`);
   
      const sortedClients = this.clients.sort((a, b) => a.ownerName.localeCompare(b.ownerName));
   
      sortedClients.forEach((client) => {
        result.push(`${client.ownerName} with:`);
        const sortedPets = client.pets.sort((a, b) => a.petName.localeCompare(b.petName));
        sortedPets.forEach((pet) => {
          result.push(`---${pet.petName} - a ${pet.kind.toLowerCase()} that needs: ${pet.procedures.join(', ')}`);
        });
      });
   
      return result.join('\n');
    }
   
    calculateBill(pet) {
      return pet.procedures.length * 500;
    }
  }