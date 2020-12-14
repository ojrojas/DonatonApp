import { Component, OnInit } from '@angular/core';
import { DonationPerishable } from 'src/app/models/donation-perishable.model';
import { EnumsModeForms } from 'src/app/models/enums.model';

@Component({
  selector: 'app-donation-perishable',
  templateUrl: './donation-perishable.component.html',
  styleUrls: ['./donation-perishable.component.scss']
})
export class DonationPerishableComponent implements OnInit {
  donationPerishable: DonationPerishable;
  mode: EnumsModeForms;
  constructor() { }

  ngOnInit(): void {
  }

}
