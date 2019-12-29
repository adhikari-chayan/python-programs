def demo_if():
    test_grade=95
    if(test_grade >94):
        print("You did awesome!!")
    elif(test_grade>85):
        print("You did good!!")
    else:
        print("You did not work hard!!")
    
    if((test_grade >=90) and (test_grade<=95)):
        print("You almost reached excellence!!")

def demo_lists():
    print('Create, print entire list and just first friend')
    print('------------------------------------------------')
    friend_list=['Sky','Marcel','Robin','Khaleel','Connie']
    print("All friends = ",friend_list)
    print("First friend = ",friend_list[0])

    friend_list[0]="Taylor"
    print("First friend with name change = ",friend_list[0]);

    print("Partial list of friends = "+ str(friend_list[2:5]))      
    #List of lists
    family_list=['Mom','Dad','Cousin']
    people_list=[friend_list,family_list]
    print("\nWrite out people_list:")
    print("-------------------------")
    print(people_list)
    print("\nWrite 3rd element from 2nd list:")
    print("-------------------------------------")
    
    print("Third person in 2nd list is",people_list[1][2])
    



def main():
    #demo_if()
    demo_lists()

if __name__=="__main__":
    main()    