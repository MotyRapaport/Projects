import { Component, OnInit } from '@angular/core';
import { BucketService } from 'src/app/services/bucket.service';
import { PriceService } from 'src/app/services/price.service';
import { VariablesService } from 'src/app/services/variables.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
  searchItem: {search: string};
  constructor(private variablesServices: VariablesService, private bucketService: BucketService, private priceService:PriceService) {
this.searchItem = {search: ""};
   }

  ngOnInit(): void {
  }
makeSearch(search: string){
this.variablesServices.getSearchItem(search);
console.log(search);
}

toggle(){

  this.variablesServices.toggleOpenBucket();
}
 
setPrice(price:number){
  this.priceService.setPrice(price);
}

}

