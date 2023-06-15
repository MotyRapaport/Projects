import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'price'
})
export class PricePipe implements PipeTransform {

  transform(price:number, discount:number): number {
    return price * (1- discount);
  }

}
