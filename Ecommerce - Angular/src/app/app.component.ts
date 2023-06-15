import { Component } from '@angular/core';
import { skip } from 'rxjs';
import { MessageService } from './services/message.service';
import { VariablesService } from './services/variables.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'MyStore';
  openBucket: {open: boolean};
  changeOpacity!: {opacity: boolean};
  constructor(private variablesSerivces: VariablesService,private msgService:MessageService){
    this.openBucket = variablesSerivces.returnOpenBucket();
    this.msgService.getMessage().pipe(skip(1)).subscribe((m) => {
      
    }
 
   
    )
    this.changeOpacity = variablesSerivces.returnOpacity();
  }
}
