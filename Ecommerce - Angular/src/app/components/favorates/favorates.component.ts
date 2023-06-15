import { Component, OnInit } from '@angular/core';
import { Bucket } from 'src/app/Models/bucket';
import { ItemsService } from 'src/app/services/items.service';

@Component({
  selector: 'app-favorates',
  templateUrl: './favorates.component.html',
  styleUrls: ['./favorates.component.css']
})
export class FavoratesComponent implements OnInit {
favorates:Bucket[];
  constructor(private itemsService:ItemsService) {
    this.favorates = itemsService.returnFav();
   }

  ngOnInit(): void {
  }

}
