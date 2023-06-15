import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Items } from 'src/app/Models/items';

@Component({
  selector: 'app-item-info',
  templateUrl: './item-info.component.html',
  styleUrls: ['./item-info.component.css']
})
export class ItemInfoComponent implements OnInit {
  @Input() singleItem!: Items;
  @Output() buttonClicked = new EventEmitter<Items>();
  constructor() { }

  ngOnInit(): void {
  }

  clickEvent(){
    this.buttonClicked.emit(this.singleItem);
  }
}
