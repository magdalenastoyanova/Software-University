class Bank {
    constructor(bankName) {
      this._bankName = bankName;
      this.allCustomers = [];
    }
   
    newCustomer(customer) {
      if (this.allCustomers.find(((c) => c.firstName === customer.firstName)
    && ((c) => c.lastName === customer.lastName)
    && ((c) => c.personalId === customer.personalId))) {
        throw new Error(`${customer.firstName} ${customer.lastName} is already our customer!`);
      } else {
        this.allCustomers.push(customer);
        return customer;
      }
    }
   
    depositMoney(personalId, amount) {
      if (!this.allCustomers.find((c) => c.personalId === personalId)) {
        throw new Error('We have no customer with this ID!');
      } else {
        const customer = this.allCustomers.find((c) => c.personalId === personalId);
        if (customer.hasOwnProperty('totalMoney')) {
          customer.totalMoney += amount;
        } else {
          customer.totalMoney = 0;
          customer.totalMoney += amount;
        }
        if (customer.hasOwnProperty('transactions')) {
          customer.transactions.count++;
          customer.transactions.push(`${customer.transactions.count}. ${customer.firstName} ${customer.lastName} made deposit of ${amount}$!`);
        } else {
          customer.transactions = [];
          customer.transactions.count = 1;
          customer.transactions.push(`${customer.transactions.count}. ${customer.firstName} ${customer.lastName} made deposit of ${amount}$!`);
        }
        return `${customer.totalMoney}$`;
      }
    }
   
    withdrawMoney(personalId, amount) {
      if (!this.allCustomers.find((c) => c.personalId === personalId)) {
        throw new Error('We have no customer with this ID!');
      } else {
        const customer = this.allCustomers.find((c) => c.personalId === personalId);
        if (!customer.totalMoney || customer.totalMoney < amount) {
          throw new Error(`${customer.firstName} ${customer.lastName} does not have enough money to withdraw that amount!`);
        } else {
          customer.totalMoney -= amount;
          if (customer.hasOwnProperty('transactions')) {
            customer.transactions.count++;
            customer.transactions.push(`${customer.transactions.count}. ${customer.firstName} ${customer.lastName} withdrew ${amount}$!`);
          } else {
            customer.transactions = [];
            customer.transactions.count = 1;
            customer.transactions.push(`${customer.transactions.count}. ${customer.firstName} ${customer.lastName} withdrew ${amount}$!`);
          }
          return `${customer.totalMoney}$`;
        }
      }
    }
   
    customerInfo(personalId) {
      if (!this.allCustomers.find((c) => c.personalId === personalId)) {
        throw new Error('We have no customer with this ID!');
      } else {
        const customer = this.allCustomers.find((c) => c.personalId === personalId);
        return `${`Bank name: ${this._bankName}` + '\n'
    + `Customer name: ${customer.firstName} ${customer.lastName}` + '\n'
    + `Customer ID: ${customer.personalId}` + '\n'
    + `Total Money: ${customer.totalMoney}$` + '\n'
    + 'Transactions:' + '\n'}${
          `${customer.transactions.reverse().join('\n')}`.trim()}`;
      }
    }
  }
   
  