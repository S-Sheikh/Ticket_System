import { Ticket } from './ticket.model';
export class Bug extends Ticket{
    constructor(title: string, date: Date, description: string, effort: string) {
        super(title, date, description, effort);
      }
}