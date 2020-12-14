import { Component, OnInit } from '@angular/core';
import { DonationMoney } from 'src/app/models/donation-money.model';
import { DonationNonPerishable } from 'src/app/models/donation-non-perishable.model';
import { DonationPerishable } from 'src/app/models/donation-perishable.model';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {
  donationMoneys: DonationMoney[];
  donationPerishables: DonationPerishable[];
  donationNonPerishables: DonationNonPerishable[];
  constructor() { }

  ngOnInit(): void {
  }

}
