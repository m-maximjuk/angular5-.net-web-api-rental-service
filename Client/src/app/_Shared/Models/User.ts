import { Profile } from "./Profile";

export class User extends Profile {
    public SSID: string;
    public BirthDate: Date;
    public DiscountRate: number;
    public Role: Roles;
    public Gender: Genders;
    public Firstname: string;
    public Lastname: string;
}
export enum Genders {
    Genders = 0,
    Male,
    Female
}
export enum Roles {
    Roles = 0,
    Customer,
    Employee,
    Manager,
    Admin
}
