package esprit.tn.services;

import java.util.List;

import javax.ejb.Remote;

import esprit.tn.entities.Message;

@Remote

public interface MessageServiceRemote {
public void ajouterMessage(Message e) ; 
public List<Message> findAll() ; 
public void DeleteMessageById(int MessageId) ; 

}
