import { Bank } from "./bank.model";
import { Donation } from "./donation.model";

export interface DonationMoney extends Donation {
    value: number;
    dateDonation: Date;
    bank: Bank;
    bankId: string;
}