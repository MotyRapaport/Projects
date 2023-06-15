import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class PriceService {
price!: {num: number};
  constructor() {
    this.price = {num: 0};
   }

   setPrice(num: number){
    this.price.num = num;
   }
   getPrice(){
    return this.price;
   }
}
