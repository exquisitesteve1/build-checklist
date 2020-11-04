import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

import { UserView } from '../../ViewModels/user-view-model';
import { Observable } from 'rxjs';
import { UserService } from '../../services/User.service';
@Component({
  selector: 'app-user-administration',
  templateUrl: './user-administration.component.html',
  styleUrls: ['./user-administration.component.css']
})
export class UserAdministrationComponent implements OnInit {

  User: UserView[];
  tempUser: UserView[];
  editedUser: UserView[];
  tempStorage: UserView[];
  newId: number;

  constructor(private userService: UserService, private modalService: NgbModal) { }

  ngOnInit(): void {
    this.refreshList();
  }

  refreshList(): void{
    this.userService.getUserList().subscribe((items) => {
      this.User = items;
      this.tempUser = this.User;
    });
  }

}
