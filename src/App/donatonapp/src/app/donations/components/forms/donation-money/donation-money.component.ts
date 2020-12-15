import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthService } from 'src/app/auth/services/auth.service';
import { DonationsService } from 'src/app/donations/services/donations.service';
import { ApplicationUser } from 'src/app/models/application-user.model';
import { Bank } from 'src/app/models/bank.model';
import { DonationMoney } from 'src/app/models/donation-money.model';
import { EnumsModeForms } from 'src/app/models/enums.model';
import { TypeDonation } from 'src/app/models/typedonation.model';
import { TypeIdentification } from 'src/app/models/typeidentification.model';
import { ModalSharedService } from 'src/app/shared/components/modal-shared/services/modal-shared.service';

@Component({
  selector: 'app-donation-money',
  templateUrl: './donation-money.component.html',
  styleUrls: ['./donation-money.component.scss']
})
export class DonationMoneyComponent implements OnInit {

  @Input() donationMoney: DonationMoney;
  @Input() typeIdentifications: TypeIdentification[];
  @Input() typeDonations: TypeDonation[];
  @Input() banks: Bank[];

  mode: EnumsModeForms;
  form: FormGroup;
  userApp: ApplicationUser;

  constructor(
    private modalServices: ModalSharedService,
    private fb: FormBuilder,
    private service: DonationsService,
    private authService: AuthService
  ) { }

  ngOnInit(): void {
    this.authService.getUserApp().subscribe(result => this.userApp = result).unsubscribe();
    switch (this.mode) {
      case EnumsModeForms.Create:
        this.createForm();
        break;
      default:
        break;
    }
  }

  createForm(): void {
    this.form = this.fb.group({
      value: new FormControl({ value: null, disabled: false }, Validators.required),
      dateDonation: new FormControl({ value: null, disabled: false }, Validators.required),
      bankId: new FormControl({ value: null, disabled: false }, Validators.required),
      typeIdentificationId: new FormControl({ value: null, disabled: false }, Validators.required),
      identification: new FormControl({ value: null, disabled: false }, Validators.required),
      donor: new FormControl({ value: null, disabled: false }, Validators.required)
    });
  }

  close(): void {
    this.modalServices.close();
  }

  submit(): void {
    if (this.form.valid) {
      switch (this.mode) {
        case EnumsModeForms.Create:
          this.service.createDonationsMoney(this.sendValueCreate());
          break;
        default:
          break;
      }
    } else {
      this.markValidityForm();
    }
  }

  sendValueCreate(): DonationMoney {
    return {
      value: this.form.value.value,
      dateDonation: this.form.value.dateDonation,
      bankId: this.form.value.bankId,
      typeIdentificationId: this.form.value.typeIdentificationId,
      identification: this.form.value.identification,
      donor: this.form.value.donor,
      state: true,
      createdBy: this.userApp.id,
      createdOn: new Date()
    } as DonationMoney;
  }

  markValidityForm(): void {
    for (const control in this.form.controls) {
      this.form.controls[control].markAsDirty();
      this.form.controls[control].markAsTouched();
    }
  }
}
