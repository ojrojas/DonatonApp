import { Component, OnInit } from '@angular/core';
import { DonationNonPerishable } from 'src/app/models/donation-non-perishable.model';
import { EnumsModeForms } from 'src/app/models/enums.model';

@Component({
  selector: 'app-donation-non-perishable',
  templateUrl: './donation-non-perishable.component.html',
  styleUrls: ['./donation-non-perishable.component.scss']
})
export class DonationNonPerishableComponent implements OnInit {
  donationNonPerishable: DonationNonPerishable;
  mode: EnumsModeForms;
  constructor() { }

  ngOnInit(): void {
  }

}
