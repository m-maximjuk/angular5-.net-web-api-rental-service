export class Model {
    public ID:       number;
    public IsActive: boolean;
    public Created:  Date;
    public Title:    string;

    constructor() {
        this.IsActive = false;
    }
}
