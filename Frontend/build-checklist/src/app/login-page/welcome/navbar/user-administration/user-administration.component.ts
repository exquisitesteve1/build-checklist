import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

import { UserView } from '../../ViewModels/user-view-model';
import { Observable } from 'rxjs';
import { UserService } from '../../services/User.service';
import { UserEditorComponent } from './user-editor/user-editor.component';
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

  onEditClick(user:UserView): void{
    var ref = this.modalService.open(UserEditorComponent);
    ref.componentInstance.user = user;

    ref.result.then((result) => this.onUserEdited(result)).catch(error => alert('Edit operation cancelled by user. No changes were made.'));
  }

  onUserEdited(editedUser: UserView): void{
    this.userService.updateUserInDB(editedUser).subscribe((editedItem)=>{
      alert("User edited successfully");
      this.refreshList();
    });
  }

}
