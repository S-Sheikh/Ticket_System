export class Ticket {
    public get effort(): string {
        return this.Effort;
    }
    public set effort(value: string) {
        this.Effort = value;
    }
    public get description(): string {
        return this.Description;
    }
    public set description(value: string) {
        this.Description = value;
    }
    public get date(): Date {
        return this.Date;
    }
    public set date(value: Date) {
        this.Date = value;
    }
    public get title(): string {
        return this.Title;
    }
    public set title(value: string) {
        this.Title = value;
    }
    // Fields
    constructor(private Title: string,
                private Date: Date,
                private Description: string,
                private Effort: string){
    }
}
