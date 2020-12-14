import { Component, OnInit } from '@angular/core';
import { DonationMoney } from 'src/app/models/donation-money.model';
import { EnumsModeForms } from 'src/app/models/enums.model';

@Component({
  selector: 'app-donation-money',
  templateUrl: './donation-money.component.html',
  styleUrls: ['./donation-money.component.scss']
})
export class DonationMoneyComponent implements OnInit {

  donationMoney: DonationMoney;
  mode: EnumsModeForms;
  constructor() { }

  ngOnInit(): void {
  }

}
