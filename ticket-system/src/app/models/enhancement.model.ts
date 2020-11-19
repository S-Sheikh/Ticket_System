import { Ticket } from './ticket.model';


export class Enhancement extends Ticket{
    public get clientDescription(): string {
        return this.ClientDescription;
    }
    public set clientDescription(value: string) {
        this.ClientDescription = value;
    }
    public get product(): string {
        return this.Product;
    }
    public set product(value: string) {
        this.Product = value;
    }
    // Fields
    constructor(title: string,
                date: Date,
                description: string,
                effort: string,
                private Product: string,
                private ClientDescription: string){
        super(title, date, description, effort);
    }
}
