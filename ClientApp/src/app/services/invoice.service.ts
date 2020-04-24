import { Injectable, Inject } from '@angular/core';  
import { Http, Response } from '@angular/http';  
import { Observable } from 'rxjs';  

  
@Injectable()  
export class InvoiceService {  
    myAppUrl: string = "";  
  
  constructor(
    private _http: Http, @Inject('BASE_URL') baseUrl: string
  ) {  
        this.myAppUrl = baseUrl;  
  }

  saveEmployee(invoice) {  
        return this._http.post(this.myAppUrl + 'api/Employee/Create', invoice)    
    }  
 
    errorHandler(error: Response) {  
        console.log(error);  
        return Observable.throw(error);  
    }  
}  
