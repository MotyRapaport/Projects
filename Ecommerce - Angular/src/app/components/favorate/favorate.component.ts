import { Component, Input, OnInit } from '@angular/core';
import { Bucket } from 'src/app/Models/bucket';

@Component({
  selector: 'app-favorate',
  templateUrl: './favorate.component.html',
  styleUrls: ['./favorate.component.css']
})
export class FavorateComponent implements OnInit {
@Input() fav!:Bucket;
  
  constructor() { }

  ngOnInit(): void {
  }

}
