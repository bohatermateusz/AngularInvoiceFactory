import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-invoice',
  templateUrl: './invoice.component.html',
  styleUrls: ['./invoice.component.scss']

})


export class InvoiceComponent implements OnInit {
  invoiceForm: FormGroup;
  title: string = "Create";
  invoiceId: number;
  errorMessage: any;
  cityList: Array<any> = [];
  paymentchoice: string;
  choices: string[] = ['Przelew', 'Karta', 'Gotówka'];
  Confirmation: string = "";


  constructor() {
  }

  ngOnInit() {
    
  }

  save()
  {
    this.Confirmation = "Dodano";
    //TODO: Service link to POST messages in Invoice service
  }

}

  

