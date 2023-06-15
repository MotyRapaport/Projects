import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Items } from 'src/app/Models/items';
import { ImgPipe } from 'src/app/pipe/img.pipe';
import { PriceService } from 'src/app/services/price.service';
import { VariablesService } from 'src/app/services/variables.service';

@Component({
  selector: 'app-item-card',
  templateUrl: './item-card.component.html',
  styleUrls: ['./item-card.component.css']
})
export class ItemCardComponent implements OnInit {
@Input() singleItem!: Items;
@Output() buttonClicked = new EventEmitter<Items>();
@Output() buttonDec = new EventEmitter<Items>();
@Input()small!:boolean;
@Output() addToFav = new EventEmitter<Items>();
updatedPrice!: {num: number};

  constructor(private priceService: PriceService) {
    this.updatedPrice = priceService.getPrice();
   }

  ngOnInit(): void {
  }

  clickInc(){
    this.buttonClicked.emit(this.singleItem);
  }
  clickDec(){
this.buttonDec.emit(this.singleItem);
  }
  addFav(){
this.addToFav.emit(this.singleItem);
  }
}
