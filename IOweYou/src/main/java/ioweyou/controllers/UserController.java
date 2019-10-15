package ioweyou.controllers;

import ioweyou.CreateUserRequest;
import ioweyou.ListUsersResponse;
import ioweyou.services.UserService;
import lombok.AllArgsConstructor;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

@AllArgsConstructor
@RestController
public class UserController {
    private final UserService userService;

    @RequestMapping(value = "/users", method = RequestMethod.GET)
    public ListUsersResponse listUsers() {
        return userService.listUsers();
    }

    @RequestMapping(value = "/add", method = RequestMethod.POST)
    public void CreateUser(@RequestBody CreateUserRequest request) {
        userService.addUser(request.getUser());
    }
}
