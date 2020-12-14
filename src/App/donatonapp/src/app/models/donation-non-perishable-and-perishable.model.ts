import { Donation } from "./donation.model";

export interface DonationNonPerishableAndPerishable extends Donation {
    city: string;
    address: string;
    deliveryTime: Date;
    deliveryName: string;
    contactNumber: string;
}