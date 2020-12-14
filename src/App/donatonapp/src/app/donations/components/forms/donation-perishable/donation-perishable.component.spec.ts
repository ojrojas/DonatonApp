import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DonationPerishableComponent } from './donation-perishable.component';

describe('DonationPerishableComponent', () => {
  let component: DonationPerishableComponent;
  let fixture: ComponentFixture<DonationPerishableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DonationPerishableComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DonationPerishableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
