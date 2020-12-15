import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthService } from 'src/app/auth/services/auth.service';
import { DonationsService } from 'src/app/donations/services/donations.service';
import { ApplicationUser } from 'src/app/models/application-user.model';
import { DonationPerishable } from 'src/app/models/donation-perishable.model';
import { EnumsModeForms } from 'src/app/models/enums.model';
import { TypeDonation } from 'src/app/models/typedonation.model';
import { TypeIdentification } from 'src/app/models/typeidentification.model';
import { ModalSharedService } from 'src/app/shared/components/modal-shared/services/modal-shared.service';

@Component({
  selector: 'app-donation-perishable',
  templateUrl: './donation-perishable.component.html',
  styleUrls: ['./donation-perishable.component.scss']
})
export class DonationPerishableComponent implements OnInit {
  @Input() donationPerishable: DonationPerishable;
  @Input() typeIdentifications: TypeIdentification[];
  @Input() typeDonations: TypeDonation[];

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
      address: new FormControl({ value: null, disabled: false }, Validators.required),
      city: new FormControl({ value: null, disabled: false }, Validators.required),
      contactNumber: new FormControl({ value: null, disabled: false }, Validators.required),
      dateExpiration: new FormControl({ value: null, disabled: false }, Validators.required),
      deliveryName: new FormControl({ value: null, disabled: false }, Validators.required),
      deliveryTime: new FormControl({ value: null, disabled: false }, Validators.required),
      description: new FormControl({ value: null, disabled: false }, Validators.required),
      donor: new FormControl({ value: null, disabled: false }, Validators.required),
      identification: new FormControl({ value: null, disabled: false }, Validators.required),
      quantity: new FormControl({ value: null, disabled: false }, Validators.required),
      typeIdentificationId: new FormControl({ value: null, disabled: false }, Validators.required),
      unitMeasurement: new FormControl({ value: null, disabled: false }, Validators.required),
    });
  }

  close(): void {
    this.modalServices.close();
  }

  submit(): void {
    if (this.form.valid) {
      switch (this.mode) {
        case EnumsModeForms.Create:
          this.service.createDonationsPerishable(this.sendValueCreate());
          break;
        default:
          break;
      }
    } else {
      this.markValidityForm();
    }
  }

  sendValueCreate(): DonationPerishable {
    return {
      typeIdentificationId: this.form.value.typeIdentificationId,
      identification: this.form.value.identification,
      donor: this.form.value.donor,
      state: true,
      address: this.form.value.address,
      city: this.form.value.city,
      contactNumber: this.form.value.contactNumber,
      dateExpiration: this.form.value.dateExpiration,
      deliveryName: this.form.value.deliveryName,
      deliveryTime: this.form.value.deliveryTime,
      description: this.form.value.description,
      quantity: this.form.value.quantity,
      unitMeasurement: this.form.value.unitMeasurement,
      createdBy: this.userApp.id,
      createdOn: new Date()
    } as DonationPerishable;
  }

  markValidityForm(): void {
    for (const control in this.form.controls) {
      this.form.controls[control].markAsDirty();
      this.form.controls[control].markAsTouched();
    }
  }
}
