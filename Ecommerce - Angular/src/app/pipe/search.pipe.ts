import { Pipe, PipeTransform } from '@angular/core';
import { Items } from '../Models/items';

@Pipe({
  name: 'search'
})
export class SearchPipe implements PipeTransform {

  transform(items: Items[], searchItm:string): Items[] {
    searchItm.toLocaleLowerCase();
    return items.filter(f => f.Name.toLocaleLowerCase().includes(searchItm));
  }

}
