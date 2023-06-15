import { Component, Input, OnInit } from '@angular/core';
import { count, filter, take, timeout, timer } from 'rxjs';
import { Message, MessageType } from 'src/app/Models/message';
import { MessageService } from 'src/app/services/message.service';

@Component({
  selector: 'app-messages',
  templateUrl: './messages.component.html',
  styleUrls: ['./messages.component.css']
})
export class MessagesComponent implements OnInit {
  @Input() msg!: Message;
  showMsg!: boolean;
  constructor(private msgService: MessageService) {
    msgService.getMessage().pipe(filter((f) => {return f.Type != MessageType.None}), take(1)).subscribe(
      (m) => {
        this.showMsg = true;
      }
    )
 //setTimeout(() => {
 //  this.showMsg = false;
 //}, 10000);
    
  }

  ngOnInit(): void {
  }

}
