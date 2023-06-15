import { Component, OnInit } from '@angular/core';
import { Items } from 'src/app/Models/items';
import { BucketService } from 'src/app/services/bucket.service';
import { ItemsService } from 'src/app/services/items.service';
import { VariablesService } from 'src/app/services/variables.service';
import { SearchPipe } from 'src/app/pipe/search.pipe';
import { Bucket } from 'src/app/Models/bucket';

@Component({
  selector: 'app-items',
  templateUrl: './items.component.html',
  styleUrls: ['./items.component.css']
})
export class ItemsComponent implements OnInit {
  items: Items[];
  itemsFiltered: Items[];
  searchItems: {search: string};
  constructor(private bucketService: BucketService, private itemsService: ItemsService, private variablesService: VariablesService ) {
    this.items = itemsService.getItems();
    this.itemsFiltered = this.items.filter(f => f.Active);
    this.searchItems = variablesService.returnSearchItem();
  }


  ngOnInit(): void {
  }

  addItem(item: Items) {
    this.bucketService.addToBucket(item);
    this.itemsService.reductItem(item);
  }
removeItem(item:Items){
  this.bucketService.removeItm(item as Bucket)
}
addFav(item:Items){
  let buckt = new Bucket();
  buckt = {Id: item.Id, Name: item.Name, Discription: item.Discription, Active: item.Active, Catagory: item.Catagory, Qty: item.Qty, Img: item.Img, price: item.price, buyingQnt: 0};
  this.itemsService.addToFav(buckt);
}
}
