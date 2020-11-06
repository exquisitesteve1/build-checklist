import { Injectable } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { ConversionsView } from '../ViewModels/conversions-view-model';

@Injectable({
  providedIn: 'root'
})
export class ConversionsService {

  baseUrl = environment.baseUrl + '/conversions';
  constructor(private httpClient: HttpClient) { }

  getConversionsList(): Observable<ConversionsView[]> {
    return this.httpClient.get<ConversionsView[]>(this.baseUrl + '/getallconversions');
  }

  updateUserInDB(conversion: ConversionsView): Observable<ConversionsView>{
    return this.httpClient.post<ConversionsView>(this.baseUrl + '/editconversion/' + conversion.ConversionId, conversion);
  }

  addNewConversionToDB(newConversion: ConversionsView): Observable<ConversionsView>{
    return this.httpClient.post<ConversionsView>(this.baseUrl + '/addconversion', newConversion);
  }
}
