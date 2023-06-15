export class Message{
   Topic!: string;
   Subject!: string;
   Type!: MessageType;
}

export enum MessageType{
    None,
    Success,
    Error
}