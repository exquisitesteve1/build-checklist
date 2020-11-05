import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { UserView } from '../ViewModels/user-view-model';

@Injectable({
  providedIn: 'root'
})

export class UserService {

  baseUrl = environment.baseUrl + '/user';
  constructor(private httpClient: HttpClient){}

  getUserList(): Observable<UserView[]> {
    return this.httpClient.get<UserView[]>(this.baseUrl + '/getallusers');
  }

  updateUserInDB(user: UserView): Observable<UserView>{
    return this.httpClient.post<UserView>(this.baseUrl + '/edituser/' + user.UserId, user);
  }

}
