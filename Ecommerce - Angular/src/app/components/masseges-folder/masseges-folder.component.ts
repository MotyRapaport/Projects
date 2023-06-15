import { Component, OnInit } from '@angular/core';
import { filter } from 'rxjs';
import { Message, MessageType } from 'src/app/Models/message';
import { MessageService } from 'src/app/services/message.service';
import { VariablesService } from 'src/app/services/variables.service';

@Component({
  selector: 'app-masseges-folder',
  templateUrl: './masseges-folder.component.html',
  styleUrls: ['./masseges-folder.component.css']
})
export class MassegesFolderComponent implements OnInit {

  messages:Message[];
  index!:number;
  constructor(private msgService: MessageService, private variableService: VariablesService) {
this.messages = [];

msgService.getMessage().pipe(filter( (m) => {return m.Type != MessageType.None})).subscribe( (m) =>
{
  this.messages.push(m);
 variableService.opacityTrue();
  setTimeout(() => {
    let index = this.messages.findIndex((f) => f == m);
    console.log(index);
    this.messages.splice(index, 1);
    if(this.messages.length == 0){
      this.variableService.opacityFalse();
        }
  }, 1000);
})


   }

  ngOnInit(): void {
  }

}
