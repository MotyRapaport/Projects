import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { Message, MessageType } from '../Models/message';

@Injectable({
  providedIn: 'root'
})
export class MessageService {

  message!:BehaviorSubject<Message>;
  msg!:Message;
  constructor() { 
    this.msg = {Topic: '', Subject: '', Type: MessageType.None};
    this.message = new BehaviorSubject(this.msg);
  }

  setMessage(msg: Message){
    this.message.next(msg);
  }

  getMessage():Observable<Message>{
    return this.message;
  }
}
